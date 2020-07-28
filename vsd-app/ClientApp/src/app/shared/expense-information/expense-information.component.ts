import { FormBase } from "../form-base";
import { OnInit, Component, Input, OnDestroy } from "@angular/core";
import { DateAdapter, MAT_DATE_LOCALE, MAT_DATE_FORMATS, MatDialog, MatDatepickerInputEvent } from "@angular/material";
import { FormGroup, ControlContainer, FormControl, AbstractControl, Validators, FormArray } from "@angular/forms";
import { MomentDateAdapter } from "@angular/material-moment-adapter";
import { MY_FORMATS, ApplicationType, CRMBoolean } from "../enums-list";
import { SummaryOfBenefitsDialog } from "../../summary-of-benefits/summary-of-benefits.component";
import * as moment from 'moment';
import { Subscription } from "rxjs";

@Component({
  selector: 'app-expense-information',
  templateUrl: './expense-information.component.html',
  styleUrls: ['./expense-information.component.scss'],
  providers: [
    // `MomentDateAdapter` can be automatically provided by importing `MomentDateModule` in your
    // application's root module. We provide it at the component level here, due to limitations of
    // our example generation script.
    { provide: DateAdapter, useClass: MomentDateAdapter, deps: [MAT_DATE_LOCALE] },
    { provide: MAT_DATE_FORMATS, useValue: MY_FORMATS },
  ],
})
export class ExpenseInformationComponent extends FormBase implements OnInit, OnDestroy {
  @Input() formType: number;
  public form: FormGroup;
  ApplicationType = ApplicationType;

  BENEFITS: string[];
  ADDITIONAL_BENEFITS: string[];
  OTHER_BENEFITS: string[];
  header: string;

  showCurrentlyOffWork: boolean = false;
  today = new Date();
  minEndDate: Date;
  CRMBoolean = CRMBoolean;

  sinSubscription: Subscription;
  didMissWorkSubscription: Subscription;
  loseWagesSubscription: Subscription;
  missedWorkDueToDeathOfVictimSubscription: Subscription;

  constructor(
    private controlContainer: ControlContainer,
    private matDialog: MatDialog,
  ) {
    super();
  }

  ngOnInit() {
    this.form = <FormGroup>this.controlContainer.control;
    // console.log("expense info component");
    // console.log(this.form);

    if (this.formType === ApplicationType.Victim_Application) {
      this.header = "Loss";
      this.BENEFITS = [
        'haveMedicalExpenses',
        'haveDentalExpenses',
        'benefitsPrescription',
        'havePrescriptionDrugExpenses',
        'haveCounsellingExpenses',
        'haveLostEmploymentIncomeExpenses',
        'havePersonalPropertyLostExpenses',
        'haveProtectiveMeasureExpenses',
        'haveProtectiveMovingExpenses',
        'haveTransportationToObtainBenefits',
        'haveDisabilityExpenses',
        'haveCrimeSceneCleaningExpenses',
        'haveOtherExpenses'
      ];
      this.ADDITIONAL_BENEFITS = [
        'haveDisabilityPlanBenefits',
        'haveEmploymentInsuranceBenefits',
        'haveIncomeAssistanceBenefits',
        'haveCanadaPensionPlanBenefits',
        'haveAboriginalAffairsAndNorthernDevelopmentCanadaBenefits',
        'haveCivilActionBenefits',
        'haveOtherBenefits',
        'noneOfTheAboveBenefits'
      ];
    }
    if (this.formType === ApplicationType.IFM_Application) {
      let didMissWorkControl = this.form.get('missedWorkDueToDeathOfVictim');

      if (this.form.parent.get('crimeInformation.victimDeceasedFromCrime').value == true) {
        didMissWorkControl.setValidators([Validators.required]);
      }
      else {
        didMissWorkControl.clearValidators();
        didMissWorkControl.setErrors(null);
      }
      didMissWorkControl.updateValueAndValidity();

      this.sinSubscription = this.form.get('sin').valueChanges.subscribe((value) => {
        if (value === null) value = '';
        this.form.parent.get('personalInformation').get('sin').patchValue(value);
      });

      this.didMissWorkSubscription = didMissWorkControl.valueChanges.subscribe((value) => {
        let didYouLoseWagesControl = this.form.get('didYouLoseWages');
        let minimumOtherBenefitsSelected = this.form.get('minimumOtherBenefitsSelected');
        if (value === CRMBoolean.True) {
          didYouLoseWagesControl.setValidators([Validators.required]);
          minimumOtherBenefitsSelected.setValidators([Validators.required]);
        }
        else {
          didYouLoseWagesControl.clearValidators();
          didYouLoseWagesControl.setErrors(null);
          didYouLoseWagesControl.patchValue('');

          minimumOtherBenefitsSelected.clearValidators();
          minimumOtherBenefitsSelected.setErrors(null);
          minimumOtherBenefitsSelected.setValue(null);
        }
        didYouLoseWagesControl.updateValueAndValidity();
        minimumOtherBenefitsSelected.updateValueAndValidity();
      });

      this.loseWagesSubscription = this.form.get('didYouLoseWages').valueChanges.subscribe((value) => {
        let sinControl = this.form.get('sin');
        let daysMissedStartControl = this.form.get('daysWorkMissedStart');
        let daysMissedEndControl = this.form.get('daysWorkMissedEnd');
        let employers = this.form.get('employers') as FormArray;
        if (value === CRMBoolean.True) {
          daysMissedStartControl.setValidators([Validators.required]);
          daysMissedEndControl.setValidators([Validators.required]);
          sinControl.setValidators([Validators.required]);

          for (let i = 0; i < employers.length; ++i) {
            let employerGroup = employers.controls[i] as FormGroup;
            let employersEmployerName = employerGroup.controls['employerName'] as FormControl;
            employersEmployerName.setValidators([Validators.required]);
            // employersEmployerName.markAsTouched();
            employersEmployerName.updateValueAndValidity();
            let employersEmployerPhoneNumber = employerGroup.controls['employerPhoneNumber'] as FormControl;
            employersEmployerPhoneNumber.setValidators([Validators.required]);
            // employersEmployerPhoneNumber.markAsTouched();
            employersEmployerPhoneNumber.updateValueAndValidity();
          }
        }
        else {
          daysMissedStartControl.patchValue('');
          daysMissedStartControl.clearValidators();
          daysMissedStartControl.setErrors(null);
          daysMissedEndControl.patchValue('');
          daysMissedEndControl.clearValidators();
          daysMissedEndControl.setErrors(null);
          sinControl.clearValidators();
          sinControl.setErrors(null);
          this.form.get('mayContactEmployer').patchValue('');

          for (let i = 0; i < employers.length; ++i) {
            let employerGroup = employers.controls[i] as FormGroup;
            let employersEmployerName = employerGroup.controls['employerName'] as FormControl;
            employersEmployerName.patchValue('');
            employersEmployerName.clearValidators();
            employersEmployerName.setErrors(null);
            employersEmployerName.updateValueAndValidity();
            let employersEmployerPhoneNumber = employerGroup.controls['employerPhoneNumber'] as FormControl;
            employersEmployerPhoneNumber.patchValue('');
            employersEmployerPhoneNumber.clearValidators();
            employersEmployerPhoneNumber.setErrors(null);
            employersEmployerPhoneNumber.updateValueAndValidity();

            employerGroup.controls['employerFirstName'].patchValue('');
            employerGroup.controls['employerLastName'].patchValue('');
            employerGroup.controls['employerPhoneNumber'].patchValue('');
            employerGroup.controls['employerAddress'].get('line1').patchValue('');
            employerGroup.controls['employerAddress'].get('line2').patchValue('');
            employerGroup.controls['employerAddress'].get('city').patchValue('');
            employerGroup.controls['employerAddress'].get('postalCode').patchValue('');
            employerGroup.controls['employerAddress'].get('province').patchValue('British Columbia');
            employerGroup.controls['employerAddress'].get('country').patchValue('Canada');
          }
        }
        sinControl.updateValueAndValidity();
        daysMissedStartControl.updateValueAndValidity();
        daysMissedEndControl.updateValueAndValidity();
      });

      this.header = "Benefits";
      this.BENEFITS = [
        'haveCounsellingExpenses',
        'haveCounsellingTransportation',
        'havePrescriptionDrugExpenses'
      ];
      this.ADDITIONAL_BENEFITS = [
        'haveVocationalServicesExpenses',
        'haveIncomeSupportExpenses',
        'haveChildcareExpenses',
        'haveLegalProceedingExpenses',
        'haveFuneralExpenses',
        'haveBereavementLeaveExpenses',
        'haveLostOfParentalGuidanceExpenses',
        'haveHomeMakerExpenses',
        'haveCrimeSceneCleaningExpenses',
        'noneOfTheAboveExpenses'
      ];
      this.OTHER_BENEFITS = [
        'haveDisabilityPlanBenefits',
        'haveEmploymentInsuranceBenefits',
        'haveIncomeAssistanceBenefits',
        'haveCanadaPensionPlanBenefits',
        'haveAboriginalAffairsAndNorthernDevelopmentCanadaBenefits',
        'haveCivilActionBenefits',
        'haveOtherBenefits',
        'noneOfTheAboveBenefits'
      ];
    }
    if (this.formType === ApplicationType.Witness_Application) {
      this.header = "Benefits";
      this.BENEFITS = [
        'haveCounsellingExpenses',
        'haveCounsellingTransportation',
        'havePrescriptionDrugExpenses'
      ];
      this.ADDITIONAL_BENEFITS = [
        'haveCrimeSceneCleaningExpenses',
        'noneOfTheAboveExpenses'
      ];
    }
  }

  ngOnDestroy() {
    if (this.formType === ApplicationType.IFM_Application) {
      this.sinSubscription.unsubscribe();
      this.didMissWorkSubscription.unsubscribe();
      this.loseWagesSubscription.unsubscribe();
    }
  }

  daysWorkMissedStartChange(event: MatDatepickerInputEvent<Date>) {
    this.minEndDate = event.target.value;
    //validate that a selected end date is not before the start date
    let startDate = moment(event.target.value);

    let endDate = this.form.get('daysWorkMissedEnd').value;
    if (endDate && moment(endDate).isBefore(startDate)) {
      this.form.get('daysWorkMissedEnd').patchValue('');
      this.form.get('daysWorkMissedEnd').updateValueAndValidity();
    }
  }

  daysWorkMissedEndChange(event: MatDatepickerInputEvent<Date>) {
    let endDate = moment(event.target.value);
    this.showCurrentlyOffWork = endDate.isSame(new Date(), "day");
    // let control = this.form.get('areYouStillOffWork');
    // if (!this.showCurrentlyOffWork) {
    //     control.patchValue('');
    //     control.clearValidators();
    //     control.setErrors(null);
    // }
    // else {
    //     control.setValidators([Validators.required]);
    // }
    // control.updateValueAndValidity();
  }

  changeGroupValidity(values: any): void {
    // whenever an expenseInformation checkbox is changed we
    // set whether the minimum expenses value is met into part of the form that isn't user editable.
    let expenseMinimumMet = '';
    let x: AbstractControl[] = [];
    this.BENEFITS.forEach((benefit) => {
      x.push(this.form.get(benefit));
    });

    //determine if one of the checkboxes is true
    let oneChecked = false;
    x.forEach(c => {
      // TODO: This should always return if not null because truthy. Second if should never trigger?
      if (oneChecked)
        return;
      if (c instanceof FormControl) {
        if (c.value === true)
          oneChecked = true;
      }
    });
    // fake a 'true' as a string
    expenseMinimumMet = oneChecked ? 'yes' : '';
    this.form.patchValue({
      minimumExpensesSelected: expenseMinimumMet
    });
  }

  changeAdditionalBenefitGroupValidity(values: any): void {
    let minimumBenefitsMet = '';
    let x: AbstractControl[] = [];
    this.ADDITIONAL_BENEFITS.forEach((benefit) => {
      x.push(this.form.get(benefit));
    });
    let oneChecked = false;
    x.forEach(c => {
      if (oneChecked)
        return;

      if (c instanceof FormControl) {
        if (c.value === true)
          oneChecked = true;
      }
    });

    // fake a 'true' as a string
    minimumBenefitsMet = oneChecked ? 'yes' : '';

    this.form.patchValue({
      minimumAdditionalBenefitsSelected: minimumBenefitsMet
    });
  }

  changeOtherBenefitValidity(values: any): void {
    // whenever an expenseInformation checkbox is changed we
    // set whether the minimum expenses value is met into part of the form that isn't user editable.
    let expenseMinimumMet = '';
    let x: AbstractControl[] = [];
    this.OTHER_BENEFITS.forEach((benefit) => {
      x.push(this.form.get(benefit));
    });

    //determine if one of the checkboxes is true
    let oneChecked = false;
    x.forEach(c => {
      // TODO: This should always return if not null because truthy. Second if should never trigger?
      if (oneChecked)
        return;
      if (c instanceof FormControl) {
        if (c.value === true)
          oneChecked = true;
      }
    });
    // fake a 'true' as a string
    expenseMinimumMet = oneChecked ? 'yes' : '';
    this.form.patchValue({
      minimumOtherBenefitsSelected: expenseMinimumMet
    });
  }

  showSummaryOfBenefits(): void {
    const summaryDialogRef = this.matDialog.open(SummaryOfBenefitsDialog, { maxWidth: '800px !important', data: 'victim' });
  }

  isMyControlValid(control: AbstractControl) {
    return control.valid || !control.touched;
  }
}
