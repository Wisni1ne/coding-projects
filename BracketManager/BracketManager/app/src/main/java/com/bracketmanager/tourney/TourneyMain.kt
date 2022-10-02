package com.bracketmanager.tourney

import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.bracketmanager.R
import com.bracketmanager.main.MainApp
import com.bracketmanager.match.MatchAdapter
import com.bracketmanager.match.MatchListener
import com.bracketmanager.models.MatchModel
import kotlinx.android.synthetic.main.tourney_list.*
import kotlinx.android.synthetic.main.tourney_list.toolbarAdd
import org.jetbrains.anko.intentFor

class TourneyMain : AppCompatActivity(), MatchListener {

    lateinit var app: MainApp

    var match = MatchModel()
    var newmatch = MatchModel()
    var lastmatch = MatchModel()

    var count: Int = 0
    var countRound: Int = 1
    var countMatch: Int = 0

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.tourney_list)

        app = application as MainApp

        toolbarAdd.title = "MATCHES"
        setSupportActionBar(toolbarAdd)

        val layoutManager = LinearLayoutManager(this)
        matchSet.layoutManager = layoutManager

        loadMatches()

        if (!app.matches.equals(null)) {
            app.matches.delete(match)
        }

        generateMatches()

    }

    fun loadMatches() {
        showMatches(app.matches.findAll())
    }

    fun showMatches (matches: List<MatchModel>) {
        matchSet.adapter = MatchAdapter(matches, this)
        matchSet.adapter?.notifyDataSetChanged()
    }

    override fun onMatchClick(match: MatchModel) {
        startActivityForResult(intentFor<TourneyMatch>().putExtra("match_edit", match), AppCompatActivity.RESULT_OK)

        loadMatches()

        regenerateMatches()
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        super.onActivityResult(requestCode, resultCode, data)

        loadMatches()

        regenerateMatches()
    }

    fun generateMatches() {

        count = 0

        for (name in app.names.findAll()) {

            if (count % 2 == 0) {
                match.nameOne = name
            }

            if (count % 2 == 1) {
                match.nameTwo = name
                match.round = countRound
                app.matches.create(match.copy())
            }

            count = count + 1

        }

        while (count / 2 > 1) {

            countRound = countRound + 1

            count = count / 2

        }

    }

    fun regenerateMatches() {

        count = 0

        for (match in app.matches.findAll()) {

            if (count % 2 == 0) {

                if (match.scoreOne > match.scoreTwo) {
                    newmatch.nameOne = match.nameOne
                }

                if (match.scoreOne < match.scoreTwo) {
                    newmatch.nameOne = match.nameTwo
                }

            }

            if (count % 2 == 1) {

                if (match.scoreOne > match.scoreTwo) {
                    newmatch.nameTwo = match.nameOne
                }

                if (match.scoreOne < match.scoreTwo) {
                    newmatch.nameTwo = match.nameTwo
                }

            }

            count = count + 1

        }

        if (!newmatch.nameOne.userid.equals("") && !newmatch.nameTwo.userid.equals("") && !newmatch.equals(lastmatch)) {

            newmatch.round = countRound
            app.matches.create(newmatch.copy())

            lastmatch = newmatch

        }

    }

}