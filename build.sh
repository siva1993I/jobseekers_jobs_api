hash=`git rev-parse HEAD`
echo $hash
echo $BUILD_ID
docker build . -t jobseeker-jobs-api:$hash
docker tag jobseeker-jobs-api:$hash containerregistry1z.azurecr.io/jobseeker-jobs-api:$hash
docker tag containerregistry1z.azurecr.io/jobseeker-jobs-api:$hash containerregistry1z.azurecr.io/jobseeker-jobs-api:$BUILD_ID
echo $D_PASSWORD | docker login containerregistry1z.azurecr.io -u $D_USERNAME --password-stdin
docker push containerregistry1z.azurecr.io/jobseeker-jobs-api:$BUILD_ID
