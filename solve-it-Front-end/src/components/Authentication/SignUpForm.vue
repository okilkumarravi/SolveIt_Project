<template>
    <div>
        <Header></Header>
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="sign-up-box">
                        <div class="sign-up-snip"> 
                            <div class="header-text">Create Account </div><br><hr>
                            <div class="sign-up-space">
                                <div class="sign-up-form">
                                    <form id="signup-form" @submit.prevent="processForm">
                                    <div class="group"> <label for="mob" class="label">Mobile</label> <input id="mob" type="text" class="input" v-model="mobile" placeholder="Enter your mobile number" required> </div>
                                    <div class="group"> <label for="pass" class="label">Password</label> <input id="pass" type="password" class="input" v-model="password" data-type="password" placeholder="Create your password" required> </div>
                                    <div class="group"> <label for="pass" class="label">Repeat Password</label> <input id="pass" type="password" class="input" v-model="rpassword" data-type="password" placeholder="Repeat your password" required> </div>
                                    <div class="group"> <label for="pass" class="label">Email Address</label> <input id="pass" type="email" class="input" v-model="email" placeholder="Enter your email address" required> </div>
                                    <div class="group"> <input type="submit" class="button" value="Sign Up"> </div>
                                    <div class="foot"><router-link to="/login"> Already Member? </router-link></div>
                                    <div class="hr"></div>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <Footer></Footer>
    </div>
</template>

<script>
import Header from '../Header';
import Footer from '../Footer';
import axios from "axios";

//import {createUser} from '../../server/server.ts';

export default {
  name: 'Signup',
  components: {
      Header,
      Footer
  },
  data: function() {
      return {
      mobile: '',
      name: 'okil',
      password: '',
      rpassword: '',
      email: ''
      }
  },
  methods: {
      processForm: function(){
        var obj = {
            mobileNumber: this.mobile,
            name: this.name,
            password: this.password,
            emailId: this.email,
            class: "x",
        }
          //createUser(obj);
          const baseURI = 'https://localhost:5001/';
        var url = baseURI + 'Authentication';
        const options = {
            headers: {'content-type': 'application/json'}
        };
        var resp = axios.post(url, 
        obj
        , options)
        .then(response => {
            return response;
        })
        .catch(error => {
            return error;
        });
        console.log(resp);
      }
  }
}
</script>

<style scoped>

.sign-up-box {
    width: 100%;
    margin: auto;
    max-width: 525px;
    min-height: 630px;
    position: relative;
    box-shadow: 0 12px 15px 0 rgba(0, 0, 0, .24), 0 17px 50px 0 rgba(0, 0, 0, .19)
}

.sign-up-snip {
    width: 100%;
    height: 100%;
    position: absolute;
    padding: 90px 70px 50px 70px;
    background: rgba(0, 77, 77, .9)
}

.sign-up-snip .sign-up-form {
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    position: absolute;
    transition: all .4s linear
}

.sign-up-snip .sign-up,
.sign-up-space .group .check {
    display: none
}

.sign-up-snip .tab,
.sign-up-space .group .label,
.sign-up-space .group .button {
    text-transform: uppercase
}

.sign-up-snip .tab {
    font-size: 22px;
    padding-bottom: 5px;
    margin: 0 15px 10px 0;
    display: inline-block;
    border-bottom: 2px solid transparent
}

.sign-up-snip .sign-up+.tab {
    color: #fff;
    border-color: #1161ee
}

.sign-up-space {
    min-height: 345px;
    position: relative;
    perspective: 1000px;
    transform-style: preserve-3d
}

.sign-up-space .group {
    margin-bottom: 15px
}

.sign-up-space .group .label,
.sign-up-space .group .input,
.sign-up-space .group .button {
    width: 100%;
    color: #fff;
    display: block
}

.sign-up-space .group .input,
.sign-up-space .group .button {
    border: none;
    padding: 15px 20px;
    border-radius: 25px;
    background: rgba(255, 255, 255, .1)
}

.sign-up-space .group input[data-type="password"] {
    -webkit-text-security: circle
}

.sign-up-space .group .label {
    color: #aaa;
    font-size: 12px
}

.sign-up-space .group .button {
    background: #1161ee
}

.sign-up-space .group label .icon {
    width: 15px;
    height: 15px;
    border-radius: 2px;
    position: relative;
    display: inline-block;
    background: rgba(255, 255, 255, .1)
}

.sign-up-space .group label .icon:before,
.sign-up-space .group label .icon:after {
    content: '';
    width: 10px;
    height: 2px;
    background: #fff;
    position: absolute;
    transition: all .2s ease-in-out 0s
}

.sign-up-space .group label .icon:before {
    left: 3px;
    width: 5px;
    bottom: 6px;
    transform: scale(0) rotate(0)
}

.sign-up-space .group label .icon:after {
    top: 6px;
    right: 0;
    transform: scale(0) rotate(0)
}

.sign-up-space .group .check+label {
    color: #fff
}

.sign-up-space .group .check+label .icon {
    background: #1161ee
}

.sign-up-space .group .check+label .icon:before {
    transform: scale(1) rotate(45deg)
}

.sign-up-space .group .check+label .icon:after {
    transform: scale(1) rotate(-45deg)
}

.sign-up-snip .sign-up:checked+.tab+.sign-up-space .sign-up-form {
    transform: rotate(0)
}

*,
:after,
:before {
    box-sizing: border-box
}

.clearfix:after,
.clearfix:before {
    content: '';
    display: table
}

.clearfix:after {
    clear: both;
    display: block
}


.hr {
    height: 2px;
    margin: 5px 0 5px 0;
    background: rgba(255, 255, 255, .2)
}
.header-text{
    font-size: 32px;
    text-align: center;
}

.foot {
    text-align: center;
    color: black;
}

.card {
    width: 500px;
    left: 100px
}

a {
    color: inherit;
    text-decoration: none
}

::placeholder {
    color: #b3b3b3
}
</style>