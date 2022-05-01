def ProjectName = "RdmMemories"
def GameBackend = "GameBackend"

pipeline {

    agent any
    stages {
        stage("Build"){   
            steps {
                sh """
                dotnet restore ${GameBackend}
                dotnet build ${GameBackend}
                dotnet publish ${GameBackend}/Server --output \"Release/publish\" --configuration \"Release\" --self-contained true /p:GenerateRuntimeConfigurationFiles=true --runtime linux-x64
                """                
            }
        }
    }
}
