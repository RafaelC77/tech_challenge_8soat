# tech_challenge_8soat

## Instruções para rodar o projeto via docker compose

Na raiz do projeto execute o comando:

`docker compose up`

Para acessar o swagger use a seguinte URL:

http://localhost:8088/swagger

## Instruções para rodar o projeto via kubernetes

Navegue para a pasta onde estão localizados os arquivos `YAML`:

`cd kubernetes`

A seguir, execute os comandos abaixo na ordem em que estão:

`kubectl apply -f foodapp-configmap.yaml`  
`kubectl apply -f foodapp-pv.yaml`  
`kubectl apply -f foodapp-pvc.yaml`  
`kubectl apply -f foodapp-bd-deployment.yaml`  
`kubectl apply -f foodapp-bd-svc.yaml`  
`kubectl apply -f foodapp-api-deployment.yaml`  
`kubectl apply -f foodapp-api-svc.yaml`  
`kubectl apply -f foodapp-hpa.yaml`  

Para acessar o swagger use a seguinte URL:

http://localhost:30300/swagger

## Arquitetura do cluster kubernetes

![image](https://github.com/user-attachments/assets/88e08b6d-98f2-441b-8121-4606268f8eeb)
