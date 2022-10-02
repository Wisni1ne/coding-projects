package com.bracketmanager.tourney

import android.content.Intent
import android.os.Bundle
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.bracketmanager.R
import com.bracketmanager.main.MainApp
import com.bracketmanager.models.MatchModel
import com.bracketmanager.models.TourneyModel
import kotlinx.android.synthetic.main.load_main.*
import kotlinx.android.synthetic.main.load_main.toolbarAdd

class TourneyLoad : AppCompatActivity(), TourneyListener {

    lateinit var app: MainApp

    var match = MatchModel()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.load_main)

        app = application as MainApp

        toolbarAdd.title = "LOAD"
        setSupportActionBar(toolbarAdd)

        val layoutManager = LinearLayoutManager(this)
        loadView.layoutManager = layoutManager

        loadTourneys()

        var tourney = TourneyModel("", app.names.findAll(), app.matches.findAll())

    }

    fun loadTourneys() {
        showTourneys(app.tourneys.findAll())
    }

    fun showTourneys (tourneys: List<TourneyModel>) {
        loadView.adapter = TourneyAdapter(tourneys, this)
        loadView.adapter?.notifyDataSetChanged()
    }

    override fun onTourneyClick(tourney: TourneyModel) {
        val intent = Intent(this, TourneyMain::class.java)
        startActivity(intent)
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        loadTourneys()
        super.onActivityResult(requestCode, resultCode, data)
    }

}