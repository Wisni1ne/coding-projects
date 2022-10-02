package com.bracketmanager.tourney

import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import com.bracketmanager.R
import com.bracketmanager.main.MainApp
import com.bracketmanager.models.MatchModel
import com.bracketmanager.models.TourneyModel
import com.bracketmanager.name.NameListActivity
import kotlinx.android.synthetic.main.new_main.*
import kotlinx.android.synthetic.main.new_main.toolbarAdd
import org.jetbrains.anko.AnkoLogger
import org.jetbrains.anko.toast

class TourneyNew : AppCompatActivity(), AnkoLogger {

    lateinit var app: MainApp

    var match = MatchModel()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.new_main)

        app = application as MainApp

        toolbarAdd.title = "NEW"
        setSupportActionBar(toolbarAdd)

        buttonCreate.setOnClickListener() {

            if (!app.matches.equals(null)) {
                app.matches.delete(match)
            }

            generateMatches()

            var tourney = TourneyModel("", app.names.findAll(), app.matches.findAll())

            tourney.tourneyid = editText.text.toString()

            if (tourney.tourneyid.isEmpty()) {
                toast("Enter the name of the tourney plz.")
            }

            else {
                app.tourneys.create(tourney.copy())

                val intent = Intent(this, TourneyMain::class.java)
                startActivity(intent)

            }

        }

        buttonManage.setOnClickListener() {

            val intent = Intent(this, NameListActivity::class.java)
            startActivity(intent)

        }

        val nameCount : Int = app.names.findAll().size
        partNum.text = nameCount.toString()

    }

    fun generateMatches() {

        var count: Int = 0

        for (name in app.names.findAll()) {

            if (count % 2 == 0) {
                match.nameOne = name
            }

            if (count % 2 == 1) {
                match.nameTwo = name
                app.matches.create(match.copy())
            }

            count = count + 1

        }

    }

}