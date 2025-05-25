# Kronos Time Visualizer ⏱📊

A real-time ASP.NET Core dashboard for monitoring **Round Trip Time (RTT)** and **time drift alerts** across distributed nodes — inspired by and powered by [Rubrik’s Kronos](https://github.com/rubrikinc/kronos).

🔗 **Live Dashboard:**  
🌍 [https://kronos-time-visualizer.onrender.com/Dashboard](https://kronos-time-visualizer.onrender.com/Dashboard)

---

## 💡 Why I Built This

I created this project as part of my journey in building intelligent, practical tools that support infrastructure visibility. Clock drift and RTT discrepancies can disrupt distributed systems — and having a visual, real-time monitor makes diagnosis and decision-making easier.

This dashboard wasn’t just about building something technical — it was about making performance **tangible, observable, and sharable** in real time.

---

## 🛠 Tools & Technologies Used

| Tool/Tech               | Purpose |
|-------------------------|---------|
| **ASP.NET Core (8.0)**  | Backend and web app framework |
| **C#**                  | Backend logic and controller setup |
| **Chart.js**            | Real-time interactive data charts |
| **Render**              | Cloud platform for real-time deployment |
| **Docker**              | Containerization and deployment workflow |
| **GitHub**              | Version control and collaboration |
| **JSON API**            | Lightweight format for data exchange |

---

## 📈 Features

- 📊 Real-time RTT Chart  
- ⚠️ Drift Alerts when RTT exceeds threshold  
- 🧠 Sync Delta (Oracle vs Follower)  
- 🧾 Node Role Table: Oracle / Follower  
- 🚀 Live public URL (no local setup needed)  
- 🐳 Dockerfile included for containerized builds  

---

## 📸 Screenshots

### 🔧 Dashboard in Action
![Dashboard View](./dashboard1%20.jpg)

### 📋 Node Information Table
![Node Table](./dashboard2.jpg)

---

## 🧪 How to Run Locally

```bash
git clone https://github.com/nwalablessing/kronos-time-visualizer.git
cd kronos-time-visualizer
dotnet run
