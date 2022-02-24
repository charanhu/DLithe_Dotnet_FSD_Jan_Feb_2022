import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-image-carousel',
  templateUrl: './image-carousel.component.html',
  styleUrls: ['./image-carousel.component.css']
})
export class ImageCarouselComponent implements OnInit {
  public image1="assets/images/chicago.jpg";
  public image2="assets/images/la.jpg";
  public image3="assets/images/ny.jpg";

  constructor() { }

  ngOnInit(): void {
  }

}
