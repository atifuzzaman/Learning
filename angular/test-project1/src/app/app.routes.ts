import { Routes } from '@angular/router';
import { ProductComponent } from './product/product.component';
import { ExternalserviceComponent } from './externalservice/externalservice.component';


export const routes: Routes = [
    { path:'', component:ProductComponent },
    {path:'catservice', component: ExternalserviceComponent}

];

