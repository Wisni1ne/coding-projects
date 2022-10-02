package com.bracketmanager.front

import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import com.bracketmanager.R
import com.bracketmanager.main.MainApp
import com.bracketmanager.tourney.TourneyLoad
import com.bracketmanager.tourney.TourneyNew
import kotlinx.android.synthetic.main.front_main.*
import org.jetbrains.anko.AnkoLogger

class FrontMain : AppCompatActivity(), AnkoLogger {

    lateinit var app: MainApp

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.front_main)
        app = application as MainApp

        buttonNew.setOnClickListener() {

            val intent = Intent(this, TourneyNew::class.java)
            startActivity(intent)

        }

        buttonLoad.setOnClickListener() {

            val intent = Intent(this, TourneyLoad::class.java)
            startActivity(intent)

        }

    }

}