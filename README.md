Розробіть CI-процес для C#/.NET Core-проєкту, що автоматично збирає рішення та
запускає модульні тести при кожному коміті до гілки develop.

Створіть GitHub Actions workflow, який після проходження тестів збирає Dockerобраз проєкту та завантажує його до Docker Hub.
---
# SECRETS
```
DOCKER_USERNAME - obv
DOCKER_TOKEN - token (read and write)
```
CHANGE THE NAME OF YOUR IMAGE IN THE YAML FILE!!!
