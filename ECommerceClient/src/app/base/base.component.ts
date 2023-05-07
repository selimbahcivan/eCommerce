import { NgxSpinnerService } from "ngx-spinner";


export class BaseComponent {

  constructor(private spinner: NgxSpinnerService) { }

  showSpinner(spinnerNameType: SpinnerType) {
    this.spinner.show();
    setTimeout(() => this.hideSpinner(spinnerNameType), 1000);
  }

  hideSpinner(spinnerNameType: SpinnerType) {
    this.spinner.hide();
  }
}

export enum SpinnerType {
  SquareLoader = "s1",
  BallTrianglePath = "s2",
  BallAtom = "s3",
}