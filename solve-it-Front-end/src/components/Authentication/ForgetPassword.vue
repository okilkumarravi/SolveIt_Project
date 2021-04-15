<template>
    <div class="login-form container">
            <h2 class="header"> Forget Password  </h2> <br> 
            <div class="mb-3 row">
                <label for="staticEmail" class="col-sm-4 col-form-label">Email/Mobile-No:<span class="manadotry-tag">*</span></label>
                <div class="col-sm-8">
                    <input type="text" class="form-control" required> 
                </div>
            </div>
            <div class="header">
                <button type="button" class="btn btn-info">Send otp </button>
                <button type="button" class="btn btn-light"> Re-Send</button>
            </div>
    </div>
</template>
<script>
export default {
    name: 'forget-password'
}
</script>

<style scoped>
.login-form{
  border: 1px solid black;
}

.container {
  width: 600px;
  height: 200px;
}

.header {
    text-align: center;
}

button {
  margin: 10px;
}
</style>