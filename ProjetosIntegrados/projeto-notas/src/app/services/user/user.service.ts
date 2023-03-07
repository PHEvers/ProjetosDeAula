import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }
  testApi(){
    return this.http.get('http://localhost:7184/WeatherForecast');
  }
}
