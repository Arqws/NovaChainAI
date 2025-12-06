# ⚙️ Setup — NovaChain AI

## Prerequisites
- .NET 8 SDK
- C++17 compiler (Clang / MSVC / GCC)
- Git

---

## Quick start (development)

```bash
git clone https://github.com/Arqws/NovaChainAI.git
cd NovaChainAI
dotnet run --project backend/LocalAI.API

---

### 📄 3️⃣ docs/roadmap.md

```bash
cat > roadmap.md <<'EOF'
# 🛣 Roadmap — NovaChain AI

## Q1 — MVP
- Backend API: upload/search/ask
- Simple web UI
- Local LLM (prototype)

## Q2 — Productization
- OCR support
- Tagging and classification
- User roles + Audit logs
- Dashboard UI improvements

## Q3 — Enterprise
- Vector DB cluster / HA
- Active Directory integration
- Plugins for finance/legal workflows

## Commercial Goal
Launch paid closed beta with SMB companies.
