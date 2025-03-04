import { Routes } from '@angular/router';
import { HomeComponent } from './Components/home/home.component';
import { BlogComponent } from './Components/blog/blog.component';
import { AboutComponent } from './Components/about/about.component';

export const routes: Routes = [
    {path:"",component:HomeComponent},
    {path:"blog",component:BlogComponent},
    {path:"blogs",component:BlogComponent},
    {path:"about" ,component:AboutComponent}
];
