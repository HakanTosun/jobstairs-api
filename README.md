# JobStairs API (Localhost)

## 🚀 Projektbeschreibung
Diese API dient als Test-API für das JobStairs API Test Framework. Sie ist für lokale Tests auf `http://localhost:5122` ausgelegt.

## 📌 Voraussetzungen
- .NET SDK 6.0 oder höher
- Visual Studio oder Visual Studio Code
- API muss lokal gestartet werden

## 🚀 API Starten
1. Navigiere in das API-Projekt:
   ```bash
   cd JobStairsApi
   dotnet run
   ```
2. Die API ist erreichbar unter:
   - **URL:** `http://localhost:5122/api/apply`

## 📌 Endpunkte
- **POST /api/apply**
  - 📌 Daten:
    ```json
    {
      "name": "Max Mustermann",
      "email": "max.mustermann@example.com",
      "position": "Tester"
    }
    ```
  - 📌 Antwort:
    ```json
    {
      "message": "Bewerbung erfolgreich empfangen"
    }
    ```