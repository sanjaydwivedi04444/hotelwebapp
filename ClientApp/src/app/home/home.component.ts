import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent {
  searchedKeyword: string;
  public hotels: HotelDetail[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<HotelDetail[]>(baseUrl + 'hotel').subscribe(result => {
      debugger
      this.hotels = result;
      console.log(JSON.stringify(this.hotels));
    }, error => console.error(error));
  }
  numSequence(n: number): Array<number> {
    return Array(n);
  }
}
interface HotelDetail {
  hotelId: string;
  name: number;
  address: number;
  imageUrl: string;
  hotelUrl: string;
  rating: number;
  price: string;
  displyRating: string;
}
