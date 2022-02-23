import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'hello-angular'; //string Interpolation
  public image = "/assets/images/Charan.jpg" //property binding
  public image1 = "/assets/images/Charan.jpg"
  //Two way Binding
  public value = " ";
  //event binding
  onClick() {
    alert("welcome to event binding")
  }
}