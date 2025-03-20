import { Routes } from '@angular/router';
import { HomeComponent } from './Components/Home/home.component';
import { BlogComponent } from './Components/blog/blog.component';
import { AboutComponent } from './Components/About/about.component';
import { BlogsComponent } from './Components/blogs/blogs.component';

export const routes: Routes = [

        {path:' ',component:HomeComponent},
        { path:'home',component: HomeComponent },
        { path: 'blog/:id', component: BlogComponent },
        { path: 'blogs', component: BlogsComponent },
        { path: 'about', component: AboutComponent },
        { path: '**', redirectTo: 'home', pathMatch:'full' }
      
      
];
