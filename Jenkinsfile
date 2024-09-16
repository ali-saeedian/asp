pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                // نمایش پیام برای شروع چک‌اوت
                echo 'Starting Checkout from branch master...'
                // چک‌اوت کردن کد از برنچ مستر
                git branch: 'master', url: 'https://github.com/rezanabhani/AryanRad.git'
                // نمایش پیام پس از اتمام چک‌اوت
                echo 'Checkout completed successfully!'
            }
        }
        stage('Restore') {
            steps {
                // نمایش پیام برای شروع رستور
                echo 'Starting package restore...'
                // رستور کردن پکیج‌ها با دستور dotnet
                bat 'dotnet restore'
                // نمایش پیام پس از اتمام رستور
                echo 'Restore completed successfully!'
            }
        }
        stage('Build') {
            steps {
                // نمایش پیام برای شروع بیلد
                echo 'Starting build process...'
                // بیلد کردن پروژه
                bat 'dotnet build --configuration Release'
                // نمایش پیام پس از اتمام بیلد
                echo 'Build completed successfully!'
            }
        }
        stage('Test') {
            steps {
                // نمایش پیام برای شروع تست
                echo 'Starting unit tests...'
                // اجرای تست‌های واحد
                bat 'dotnet test'
                // نمایش پیام پس از اتمام تست
                echo 'Tests completed successfully!'
            }
        }
    }
}
