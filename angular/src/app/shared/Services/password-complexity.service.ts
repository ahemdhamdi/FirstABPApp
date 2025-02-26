import { Injectable } from '@angular/core';


export interface ProgressBarStats {
  bgColor: string;
  text?: string;
  width: number;
}


@Injectable({
  providedIn: 'root'
})
export class PasswordComplexityService {

  colors: string[] = ['#B0284B', '#F2A34F', '#5588A4', '#3E5CF6', '#6EBD70'];
  texts: string[] = ['Weak', 'Fair', 'Normal', 'Good', 'Strong'];
  
  validatePassword(password: string): ProgressBarStats {
    let score = 0;
    if (password.length >= 8) score++;
    if (/[0-9]/.test(password)) score++;
    if (/[a-z]/.test(password)) score++;
    if (/[A-Z]/.test(password)) score++;
    if (/[^a-zA-Z0-9]/.test(password)) score++;

    return {
      bgColor: this.colors[score - 1] || '#B0284B',
      text: this.texts[score - 1] || 'Weak',
      width: score * 20, // Adjust progress bar width (out of 100%)
    };

  }
}
