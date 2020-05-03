import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BlogService } from '../servives/blog.service';


@Component({
  selector: 'app-blogs-list',
  templateUrl: './blogs-list.component.html'
})
export class BlogsListComponent implements OnInit {

  blogs: any[];

  constructor(private blogService: BlogService) {


  }

  ngOnInit() {
    this.blogService.GetBlogs().subscribe(blogs => {
      this.blogs = blogs;
    });
  }

}

