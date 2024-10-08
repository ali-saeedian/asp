pipeline {
    agent any

    environment {
        PROJECT_NAME = 'AspNetCoreApp'
        ENVIRONMENT = 'Development'   // Set default to 'Development'
        Build_Type = 'Release'        // Set default to 'Release'
        PUBLISH_DIR = "C:\\Jenkins_Publish\\${PROJECT_NAME}\\${ENVIRONMENT}"
    }

    stages {
        stage('Checkout') {
            steps {
                git branch: 'master', url: 'https://github.com/rezanabhani/AryanRad.git'
            }
        }

        stage('Restore') {
            steps {
                retry(3) {
                    bat 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                bat "dotnet build --configuration ${Build_Type}"
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test'
            }
        }

        stage('Publish') {
            steps {
                bat "dotnet publish --configuration ${Build_Type} --output ${PUBLISH_DIR}"
            }
        }

        stage('Cleanup') {
            steps {
                echo 'Cleaning up workspace...'
                cleanWs()
            }
        }
    }

    post {
        success {
            mail to: 'Rezanabhani387@gmail.com',
                 subject: "Build Success : ${env.JOB_NAME} - ${env.BUILD_NUMBER}",
                 body: "Good news! The build succeeded."
        }
        failure {
            mail to: 'Rezanabhani387@gmail.com',
                 subject: "Build Failure : ${env.JOB_NAME} - ${env.BUILD_NUMBER}",
                 body: "The build failed."
        }
    }

    triggers {
        pollSCM('H/1 * * * *')
    }
}
