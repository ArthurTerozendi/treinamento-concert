import { HttpClient, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UploadFileService {

  constructor(
    private httpClient : HttpClient
  ) { }

  upload(files: Set<File>, url: string) {

    const formData = new FormData();

    files.forEach(file => formData.append('file', file, file.name));

    return this.httpClient.post(url, formData, {
      observe: 'events',
      reportProgress: true
    });
  }
}
