# 🎮 Unity CI/CD Pipeline

This project uses **GitHub Actions** to automatically test and build a Unity 6 project for:

- ✅ WebGL
- ✅ Windows (StandaloneWindows64)

Builds are zipped and uploaded to **GitHub Releases** when a release is published.

---

## 🚀 Features

- ✅ Unity version: `6000.0.45f1`
- 🧪 Runs Unity tests (EditMode/PlayMode)
- 🏗 Builds WebGL & Windows separately
- 📦 Uploads `.zip` builds to GitHub Releases
- 🐳 Uses official UnityCI Docker containers

---

## 🛠 GitHub Actions Setup

### 🔑 Required Secrets

Before the workflow can run, set the following secrets in your GitHub repo:

| Name              | Description                                |
|-------------------|--------------------------------------------|
| `UNITY_LICENSE`   | Base64 of your activated Unity `.ulf` file |
| `UNITY_EMAIL`     | Your Unity account email                   |
| `UNITY_PASSWORD`  | Your Unity account password                |

You **do not** need to manually set `GITHUB_TOKEN` – GitHub provides it automatically.

---

## 📂 CI Workflow Structure

Located at: `.github/workflows/unity-ci.yml`

### Jobs:

| Job           | Description                        |
|---------------|------------------------------------|
| `test`        | Runs Unity tests                   |
| `build-webgl`
