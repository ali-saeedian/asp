pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                // چک‌اوت کردن کد از برنچ مستر
               git branch: 'master', url: 'https://github.com/rezanabhani/AryanRad.git'
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
    }
}
