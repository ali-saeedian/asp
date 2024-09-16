pipeline {
    agent any
    stages {
        stage('Checkout'){
           steps{
             echo 'Starting Chackout from branch master'
             git branch: 'master', url: 'https://github.com/rezanabhani/AryanRad.git'
            echo 'Checkout completed '
          }   
        }
        
        stage('Restore')
        {
            steps{
                echo 'Starting package restore'
                bat 'dotnet restore'
                echo 'Restore completed successfuly'
            }
        }
        
        stage('Build'){
            steps{
                echo 'Starting build process'
                bat 'dotnet build'
                echo 'Build completed successfuly'
            }
        }
        stage('Test'){
            steps{
                echo 'Starting unit test'
                bat 'dotnet test'
                echo 'Tests completed successfuly'
            }
        }
    }
}
