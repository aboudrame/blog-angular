import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class BlogService {
  base_url: string = "api/Blogs";

  constructor(private http: HttpClient) {

  }

  GetBlogs(): Observable<any> {
    const configUrl = this.base_url + `/GetBlogs`;

    return this.http.get<any>(configUrl);
  }

  PostBlog(blog: {}): Observable<any> {
    const configUrl = this.base_url + `/PostBlog`;

    const payload = {
      blog
    }

    return this.http.post<string>(configUrl, payload);
  }
}
