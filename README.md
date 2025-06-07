# Mindfulness Console

A guide to inner peace from your terminal.

## 🌟 Description
A console application featuring three activities to reduce stress and track your progress:

- **Breathing**: guided inhale/exhale cycles.  
- **Reflection**: prompts and questions for self-discovery.  
- **Listing**: exercises to recognize positive aspects of your life.  
- **Logging**: automatic session history in `mindfulness_log.txt`.

## 🚀 Requirements
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download)

## ⚙️ Installation and Usage
```bash
git clone https://github.com/aaron040998/Mindfulness.git
cd Mindfulness
dotnet run
```
1. Choose an activity (1–3) or exit (4).  
2. Enter desired duration in seconds.  
3. Follow on-screen instructions.  
4. At the end, view your summary and log file location.

## 📂 Structure
```
/Mindfulness
├─ Activity.cs
├─ BreathingActivity.cs
├─ ReflectingActivity.cs
├─ ListingActivity.cs
├─ Program.cs
└─ mindfulness_log.txt (auto-generated)
```
