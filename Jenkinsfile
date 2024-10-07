pipeline {
    agent any
    stages {
        stage('Step 1: Clonar Repositorio') {
            steps {
                git 'https://github.com/usuario/mi-repo-dotnet.git'
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

