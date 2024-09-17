pipeline {
    agent any
    
    environment {
        PROJECT_NAME = 'AspNetCoreApp'
        PUBLISH_DIR = "C:\\Jenkins_Publish\\${PROJECT_NAME}"
    }
    
    stages {
        stage('Checkout') {
            steps {
                git branch: 'master', url: 'https://github.com/rezanabhani/AryanRad.git'
            }
        }

      
        stage('Restore') {
            steps {
                bat 'dotnet restore'
            }
        }

     
        stage('Build') {
            steps {
                bat 'dotnet build'
            }
        }

      
        stage('Test') {
            steps {
                bat 'dotnet test'
            }
        }

       
        stage('Publish') {
            steps {
                bat "dotnet publish --configuration Release --output ${PUBLISH_DIR}"
            }
        }
    
