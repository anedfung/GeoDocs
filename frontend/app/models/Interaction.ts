type Interaction = {
  "id": number,
  "eventId": number,
  "userId": number,
  "type": "like" | "comment" | "share",
  "content": string | null,
  "createdAt": Date
}
