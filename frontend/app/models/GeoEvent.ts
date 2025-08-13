type GeoEvent = {
  "id": number,
  "title": string,
  "description": string,
  "eventDate": string | null,
  "latitude": number,
  "longitude": number,
  "imageUrl": string,
  "status": "pending" | "approved",
  "createdBy": string, // username
  "createdAt": Date,
  "updatedAt": Date
}