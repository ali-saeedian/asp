pipeline {
    agent any
    
    environment {
        // متغیرهای محیطی برای نام پروژه و مسیر انتشار
        PROJECT_NAME = 'AspNetCoreApp'
        PUBLISH_DIR = "C:\\Jenkins_Publish\\${PROJECT_NAME}"
    }
    
    stages {
        // مرحله اول: چک‌اوت از مخزن GitHub
        stage('Checkout') {
            steps {
                git branch: 'master', url: 'https://github.com/rezanabhani/AryanRad.git'
            }
        }

        // مرحله دوم: رستور پکیج‌ها
        stage('Restore') {
            steps {
                bat 'dotnet restore'
            }
        }

        // مرحله سوم: بیلد پروژه
        stage('Build') {
            steps {
                bat 'dotnet build --configuration Release'
            }
        }

        // مرحله چهارم: اجرای تست‌ها
        stage('Test') {
            steps {
                bat 'dotnet test'
            }
        }

        // مرحله پنجم: انتشار پروژه
        stage('Publish') {
            steps {
                bat "dotnet publish --configuration Release --output ${PUBLISH_DIR}"
            }
        }

        // مرحله ششم: پاکسازی فایل‌های موقتی
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
             subject: "Build Success: ${env.JOB_NAME} - ${env.BUILD_NUMBER}",
             body: "Good news! The build succeeded."
    }
    failure {
        mail to: 'Rezanabhani387@gmail.com',
             subject: "Build Failure: ${env.JOB_NAME} - ${env.BUILD_NUMBER}",
             body: "Unfortunately, the build failed. Check the logs for more details."
    }
}
}
