pipeline {
    agent any
    stages {
        stage('Step 1: Clonar Repositorio') {
            steps {
                git credentialsId: 'github-ssh', url: 'git@github.com:alexq2002/G1_LoginAPI.git'
                   // Do a ls -lart to view all the files are cloned. It will be clonned. This is just for you to be sure about it.
                   sh "ls -lart ./*" 
                   // List all branches in your repo. 
                   sh "git branch -a"
                   // Checkout to a specific branch in your repo.
                   sh "git checkout branchname"
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


