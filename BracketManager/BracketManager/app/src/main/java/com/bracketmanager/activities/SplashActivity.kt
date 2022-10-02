package com.bracketmanager.activities

import android.content.Intent
import android.os.Bundle
import android.os.Handler
import androidx.appcompat.app.AppCompatActivity
import com.bracketmanager.R
import com.bracketmanager.front.FrontMain
import com.bracketmanager.main.MainApp

class SplashActivity: AppCompatActivity() {

    lateinit var app: MainApp

    override fun onCreate(savedInstanceState: Bundle?) {

        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_splash)

        scheduleSplashScreen()

    }

    private fun scheduleSplashScreen() {

        val splashScreenDuration = getSplashScreenDuration()
        Handler().postDelayed(
            {
                routeToAppropriatePage()
                finish()
            },
            splashScreenDuration
        )

    }

    private fun getSplashScreenDuration() = 1000L

    private fun routeToAppropriatePage() {

        val intent = Intent(this, FrontMain::class.java)
        startActivity(intent)

    }

}