import { UserService } from './services/user/user.service';
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'projeto-notas';

  constructor(public service: UserService){
    this.service.testApi().subscribe(
      (Response) => {
        console.log(Response);
      }
    )

  }

}
