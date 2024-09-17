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

       stage('Cleanup')
        {
            steps{
                echo 'Cleaning up workspace...'
                clenWs()
            }
       }
    }

    post{
       success {
    mail to: 'Rezanabhani387@gmail.com',
         subject:"Build Success,
         body:"Good news! the build succeded."
        }
      failure {
        mail to: 'Rezanabhani387@gmail.com',
            subject:"Build Failure,
          body:"the build failed"
      }
    }
    

  
}
