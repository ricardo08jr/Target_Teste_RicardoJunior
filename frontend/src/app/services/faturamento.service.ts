import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface FaturamentoRequest {
  valores: number[];
}

export interface FaturamentoResponse {
  menorFaturamento: number;
  maiorFaturamento: number;
  diasAcimaDaMedia: number;
}

@Injectable({
  providedIn: 'root'
})
export class FaturamentoService {
  private apiUrl = '/api/Faturamento/calcular';

  constructor(private http: HttpClient) {}

  calcular(data: FaturamentoRequest): Observable<FaturamentoResponse> {
    return this.http.post<FaturamentoResponse>(this.apiUrl, data);
  }
}
