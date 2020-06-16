import { Component, OnInit, Inject } from '@angular/core';
import { City } from './citiy';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cities',
  templateUrl: './cities.component.html',
  styleUrls: ['./cities.component.css']
})
export class CitiesComponent implements OnInit {
  public cities: City[];

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) { }

  ngOnInit(): void {
    this.http.get<City[]>(this.baseUrl + 'api/Cities')
      .subscribe(result => {
        this.cities = result;
      },
      error => console.error(error));
  }

}
