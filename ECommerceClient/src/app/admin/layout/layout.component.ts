import { Component } from '@angular/core';
declare var alertify: any; // angular.json'a yüklenen kütüphanelerden hangisinde bu şekilde komut varsa onu bind etmesini sağlar.

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.scss']
})
export class LayoutComponent {

  constructor() { }

  ngOnInit(): void {
  
  }
}
