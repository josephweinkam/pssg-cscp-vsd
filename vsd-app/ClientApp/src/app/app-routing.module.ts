import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { VictimApplicationComponent } from './victim-application/victim-application.component';
import { ApplicationCancelledComponent } from './application-cancelled/application-cancelled.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { TestApiComponent } from './test-api/test-api.component';

const routes: Routes = [
  {
    path: '',
    component: VictimApplicationComponent
  },
  {
    path: 'victim-application',
    component: VictimApplicationComponent,
  },
  {
    path: 'test-api',
    component: TestApiComponent,
  },
  {
    path: 'application-cancelled',
    component: ApplicationCancelledComponent,
  },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { scrollPositionRestoration: 'top' })],
  exports: [RouterModule],
  providers: []
})
export class AppRoutingModule { }
