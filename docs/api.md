# 📡 NovaChain AI — API (MVP)

High-level REST API for document indexing and RAG (Retrieval-Augmented Generation).

---

## POST /api/documents
Upload a document for indexing.

Request: multipart/form-data  
Response:
{
  "id": "<documentId>",
  "status": "stored"
}

---

## POST /api/search
Semantic search in indexed documents.

Request:
{
  "query": "Contract terms"
}

Response:
{
  "results": [
    { "docId": "...", "score": 0.92, "snippet": "..." }
  ]
}

---

## POST /api/ask
Ask a question based on document knowledge.

Request:
{
  "query": "What is contract #123 amount?"
}

Response:
{
  "answer": "...",
  "sources": ["docId1"]
}
