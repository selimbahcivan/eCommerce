import { Component } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';
import { Product } from 'src/app/contracts/product';
import { HttpClientService } from 'src/app/services/common/http-client.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent extends BaseComponent {

  constructor(spinner: NgxSpinnerService, private httpClientService: HttpClientService) {
    super(spinner);
  }

  ngOnInit() {
    this.showSpinner(SpinnerType.BallAtom);

    // this.httpClientService.get({
    //   controller: "products"
    // }).subscribe(data => console.log(data));

    // this.httpClientService.post({
    //   controller: "products"
    // }, {
    //   name: "Kalem",
    //   stock: 100,
    //   price: 15
    // }).subscribe();

    // this.httpClientService.put({
    //   controller: "products"
    // }, {
    //   id: 7,
    //   name: "TEST DEĞİŞTİ",
    //   stock: 31,
    //   price: 31.31
    // }).subscribe();

    // this.httpClientService.delete({
    //   controller: "products"
    // }, "7").subscribe();

    // this.httpClientService.get({
    //   // baseUrl: "https://jsonplaceholder.typicode.com",
    //   // controller: "posts"
    //   fullEndPoint : "https://jsonplaceholder.typicode.com/posts"
    // }).subscribe(data => console.log(data));

    this.httpClientService.get<Product>({
      controller: "products"
    },"11").subscribe(data => console.log(data.name));

  }
}
