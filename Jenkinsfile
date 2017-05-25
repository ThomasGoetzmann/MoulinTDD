#!groovy​

stage ('Checkout'){
    node{
        echo 'Checkout from Github'
        checkout scm
    }
}

stage ('Build'){
    node{
        echo 'Restore Nuget package'
        bat '"C:\\Program Files (x86)\\NuGet\\nuget.exe" restore ".\\source\\MoulinTDD\\MoulinTDD.sln"'
        
        def msbuild = tool 'msbuild v15.0'
        bat "\"${msbuild}\" \".\\source\\MoulinTDD\\MoulinTDD.sln\""   

        stash name: 'moulintdd-outputs', includes: 'source/MoulinTDD/MoulinTDD/bin/Debug/**'
        echo 'Binaries stashed'

        stash name: 'moulintdd-unittests', includes: '/source/MoulinTDD/MoulinTDD-UnitTests/bin/Debug/**'
        echo 'Tests stashed'
    }
}

state ('Test'){
    node{
        stage('Unit Tests'){

        }
    }
}