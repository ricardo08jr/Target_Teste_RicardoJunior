<<<<<<< Updated upstream
import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly title = signal('faturamento-app');
=======
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { FaturamentoService, FaturamentoResponse } from './services/faturamento.service';

@Component({
  selector: 'app-root',
  imports: [CommonModule, FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  inputJson: string = '[\n  100,\n  200,\n  0,\n  100\n]';
  resultado: FaturamentoResponse | null = null;
  error: string | null = null;
  isLoading: boolean = false;

  constructor(private faturamentoService: FaturamentoService) {}

  calcular() {
    this.error = null;
    this.resultado = null;
    let valores: number[];
    
    try {
      valores = JSON.parse(this.inputJson);
      if (!Array.isArray(valores) || !valores.every(v => typeof v === 'number')) {
        throw new Error('O formato deve ser um array de números.');
      }
    } catch (e: any) {
      this.error = 'JSON inválido. Certifique-se de usar o formato correto: [100, 200, 0, 100]';
      return;
    }

    this.isLoading = true;
    this.faturamentoService.calcular({ valores }).subscribe({
      next: (res) => {
        this.resultado = res;
        this.isLoading = false;
      },
      error: (err) => {
        this.error = 'Erro ao conectar com a API: ' + (err.message || 'Desconhecido');
        this.isLoading = false;
      }
    });
  }
>>>>>>> Stashed changes
}
