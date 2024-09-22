pipeline {
    agent any

  parameters{
      choice(name: 'ENVIRONMENT', choices:['Development','Production'],description: 'Select the environment')
      choice (name: 'Build_Type',choices:['Release', 'Debug'],description:'Select the build type')
  }

    environment {
        PROJECT_NAME = 'AspNetCoreApp'
        PUBLISH_DIR = "C:\\Jenkins_Publish\\${PROJECT_NAME}\\${params.ENVIRONMENT}"
    }

    stages {
        stage('Checkout') {
            steps {
                git branch: 'master', url: 'https://github.com/rezanabhani/AryanRad.git'
            }
        }

        stage('Restore') {
            steps {
                retry(3){
                bat 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                bat "dotnet build"
            }
        }

        stage('Test') {
            steps {
                bat 'dotnet test'
            }
        }

        stage('Publish') {
            steps {
                bat "dotnet publish --configuration ${params.BUILD_TYPE} --output ${PUBLISH_DIR}"
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
}
