pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                // چک‌اوت کردن کد از برنچ مستر
                git branch: 'master', credentialsId: 'your-credentials-id', url: 'https://github.com/your-repo.git'
            }
        }
        stage('Restore') {
            steps {
                // رستور کردن پکیج‌ها با دستور dotnet
                bat 'dotnet restore'
            }
        }
        stage('Build') {
            steps {
                // بیلد کردن پروژه
                bat 'dotnet build --configuration Release'
            }
        }
        stage('Test') {
            steps {
                // اجرای تست‌های واحد
                bat 'dotnet test'
            }
        }
        stage('Publish') {
            steps {
                // پابلیش کردن پروژه
                bat 'dotnet publish --configuration Release --output ./publish'
            }
        }
    }
}
