# Kronos Time Visualizer ⏱️📊

This is a real-time dashboard for monitoring **RTT (Round Trip Time)** and **time drift alerts** across nodes in a distributed system powered by [Rubrik's Kronos](https://github.com/rubrikinc/kronos).

---

## 🔍 Features

- 📈 Interactive Chart for RTT across data centers
- ⚠️ Drift Alerts when RTT > threshold
- 📋 Node Role Table showing Oracle/Follower + Sync Delta (drift from oracle)
- ✅ Built with ASP.NET Core MVC and Chart.js

---

## 📸 Preview

![RTT Chart Screenshot](screenshots/rtt_dashboard.png)

---

## 🛠️ How It Works

The backend simulates time sync data and exposes it via REST (`/api/metrics/rtt`), which the frontend fetches using JavaScript to:

- Plot RTT values as a line chart
- Display alerts for unstable nodes
- Show each node’s role and time delta (drift)

---

## 📦 Tech Stack

- ASP.NET Core MVC (C#)
- Chart.js
- REST API

---

## 👩🏽‍💻 Author

**Blessing Nwala**  
🔗 [LinkedIn](https://www.linkedin.com/in/blessing-nwala-319012118)  
📁 [Portfolio](https://nwalablessing.github.io/blessingunwala.github.io/)  

---

## 📂 Repository

https://github.com/nwalablessing/kronos-time-visualizer
