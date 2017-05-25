#!groovy​

stage ('Checkout'){
    node{
        echo 'Checkout from Github'
        checkout scm
    }
}

stage ('Build'){
    node{
        dir('TestResults'){
            deleteDir()
        }
        echo 'TestResults deleted'

        echo 'Restore Nuget package'
        bat '"C:\\Program Files (x86)\\NuGet\\nuget.exe" restore ".\\source\\MoulinTDD\\MoulinTDD.sln"'
        
        def msbuild = tool 'msbuild v15.0'
        bat "\"${msbuild}\" \".\\source\\MoulinTDD\\MoulinTDD.sln\""   

        stash name: 'moulintdd_outputs', includes: 'source/MoulinTDD/MoulinTDD/bin/Debug/**, /source/MoulinTDD/MoulinTDD-UnitTests/bin/Debug/**'
        echo 'Binaries stashed'
    }
}

stage ('Test'){
    parallel 'Unit Tests': {
        node{
            unstash 'moulintdd_outputs'
            def vstest = tool 'vstest 15.0'
            bat "\"${vstest }\" \".\\source\\MoulinTDD\\MoulinTDD-UnitTests\\bin\\Debug\\MoulinTDD-UnitTests.dll\" /Logger:trx "
            archiveArtifacts artifacts: 'TestResults/*.trx'
        }
    }, 'Other Tests': {
        node{

        }
    }
}

timeout(time:10, unit:'DAYS'){
    input message:'Archive binaries and test results ?', ok:'Archive'
}

stage ('Archive'){
    node{
        unstash 'moulintdd_outputs'
        archiveArtifacts artifacts: 'source/MoulinTDD/MoulinTDD/bin/**'
    }
}