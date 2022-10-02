package com.bracketmanager.main

import android.app.Application
import com.bracketmanager.models.*
import org.jetbrains.anko.AnkoLogger
import org.jetbrains.anko.info

class MainApp : Application(), AnkoLogger {

    lateinit var names: NameStore
    lateinit var tourneys: TourneyStore
    lateinit var matches: MatchStore

    override fun onCreate() {
        super.onCreate()

        names = NameJSONStore(applicationContext)
        tourneys = TourneyJSONStore(applicationContext)
        matches = MatchJSONStore(applicationContext)

        info("Application start")

    }
}
