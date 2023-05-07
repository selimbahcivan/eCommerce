import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.scss']
})
export class OrdersComponent extends BaseComponent {

  constructor(spinner: NgxSpinnerService) {
    super(spinner);
  }

  ngOnInit() {
    this.showSpinner(SpinnerType.BallAtom);
  }
}

