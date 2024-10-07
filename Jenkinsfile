pipeline {
    agent any
    stages {
        stage('Step 1: Clonar Repositorio') {
            steps {
                git credentialsId: 'github-ssh', url: 'git@github.com:alexq2002/G1_LoginAPI.git'
            }
        }
        stage('Step 2: Compilar Proyecto .NET') {
            steps {
                // Compilar el proyecto .NET
                echo 'Compilando el proyecto .NET...'
                sh 'dotnet build --configuration Release'
            }
        }
    }
}

