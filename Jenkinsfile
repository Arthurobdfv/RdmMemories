def ProjectName = "RdmMemories"
def GameBackend = "GameBackend"

pipeline {

    agent any
    stages {
        stage("Clean Up") {
            steps {
                deleteDir()
            }
        }

        stage("Build"){   
            steps {
                dir("${ProjectName}") {
                    sh """
                    dotnet restore ${GameBackend}
                    dotnet build ${GameBackend}
                    dotnet publish ${GameBackend}/Server --output \"Release/publish\" --configuration \"Release\" --self-contained true /p:GenerateRuntimeConfigurationFiles=true --runtime linux-x64
                    """
                }      
            }
        }
    }
}
