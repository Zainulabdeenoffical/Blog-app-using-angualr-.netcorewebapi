import { Component, inject } from '@angular/core';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import { BlogService } from '../../blog.service';
import { blog } from '../../types/blog';
@Component({
  selector: 'app-home',
  imports: [MatCardModule,MatButtonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

blogservice = inject(BlogService)

featuredblog!: blog[ ];
ngOnInit()
{

this.blogservice.getfeatureblog().subscribe(result=>{

  this.featuredblog=result
  console.log(this.featuredblog)
})

}

}
