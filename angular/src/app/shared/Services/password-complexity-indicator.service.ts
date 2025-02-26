import { Injectable } from '@angular/core';

export interface ProgressBarStats {
  bgColor: string;
  text?: string;
  width: number;
}

export interface RegexRequirementsModel {
  minLengthRegex: RegExp;
  numberRegex: RegExp;
  lowercaseRegex: RegExp;
  uppercaseRegex: RegExp;
  specialCharacterRegex: RegExp;
}

@Injectable({
  providedIn: 'root'
})
export class PasswordComplexityIndicatorService {

   // Default Colors
   private colors: string[] = ['#B0284B', '#F2A34F', '#5588A4', '#3E5CF6', '#6EBD70'];

   // Default Strength Texts
   private texts: string[] = ['Weak', 'Fair', 'Normal', 'Good', 'Strong'];
 
   // Default Password Requirements
   private requirements: RegexRequirementsModel = {
     minLengthRegex: /(?=.{6,})/,                 // Minimum length: 6 characters
     numberRegex: /(?=.*[0-9])/,                  // At least one number
     lowercaseRegex: /(?=.*[a-z ])/,              // At least one lowercase letter
     uppercaseRegex: /(?=.*[A-Z])/,               // At least one uppercase letter
     specialCharacterRegex: /[^a-zA-Z0-9 ]+/,     // At least one special character
   };
 
   constructor() {}
 
   // Password Validation Method
   validatePassword(password: string): ProgressBarStats {
     let score = 0;
 
     if (this.requirements.minLengthRegex.test(password)) score++;
     if (this.requirements.numberRegex.test(password)) score++;
     if (this.requirements.lowercaseRegex.test(password)) score++;
     if (this.requirements.uppercaseRegex.test(password)) score++;
     if (this.requirements.specialCharacterRegex.test(password)) score++;
 
     return {
       bgColor: this.colors[score],
       text: this.texts[score],
       width: (score / this.texts.length) * 100,
     };
   }
}
