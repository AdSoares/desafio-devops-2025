# DevOps2025 - Desafio Completo

Este repositório contém a solução completa para o desafio DevOps 2025 com:

- 🟦 API .NET com cache de 10 segundos
- 🟨 API Node.js com cache de 1 minuto
- 🟥 Redis como camada de cache
- 📈 Prometheus e Grafana para observabilidade
- 🐳 Docker Compose para orquestração

---

## 🚀 Como executar

```bash
git clone <repositorio>
cd desafio-devops-2025
docker-compose up --build
```

Acesse:
- .NET API: http://localhost:5000/text
- Node.js API: http://localhost:5001/text
- Grafana: http://localhost:3000 (usuário/padrão: admin/admin)

* No Grafana, é aconselhável executar o teste de carga (ver abaixo), aguardar alguns instantes e trocar o range de tempo para "Last 5 minutes" para conseguir visualizar dados.

---

## 📁 Estrutura do projeto

/devops2025\
├── app-dotnet/         = Aplicação .NET\
├── app-node/           = Aplicação Node.js\
├── diagrama/           = Diagrama de Arquitetura\
├── infra/           \
│   └── prometheus/     = Setup Prometheus\
│   └── grafana/        = Setup Grafana\
│       └── dashboards/ = Setup Dashboards Grafana\
├── load-test/           \
│   └── k6/             = Teste de carga usando k6\
└── README.md\

---

## 🕒 Testes de Carga

📦 1. Instalar o k6

- Linux\
sudo apt install k6

- Mac\
brew install k6

- Windows (via Chocolatey)\
choco install k6

▶️ 2. Executar o teste

- Suba o docker-compose:\
docker-compose up --build

- Em outro terminal, execute o arquivo load-teste/k6/test-load.js:\
k6 run test-load.js

---

## 📊 Diagrama da Arquitetura

![Diagrama de Arquitetura](diagrama/desafio-devops-2025-digrama-arquitetura-v2.drawio.png?raw=true)

## 🔧 Sugestões de melhoria

- 🔲 Adicionar autenticação via OAuth2 (Keycloak/Auth0)
- 🔲 Expor mais métricas reais (CPU, mem, HTTP status)
- 🔲 Implementar pipeline CI/CD com GitHub Actions
- 🔲 Externalizar cache Redis por volume persistente
- 🔲 Adotar Helm Charts ou Kustomize para Kubernetes 
- ✅ Realizar testes de carga com k6 para simular uso intensivo 
