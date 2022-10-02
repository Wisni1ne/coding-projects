package com.bracketmanager.name

import android.content.Intent
import android.os.Bundle
import android.view.Menu
import android.view.MenuItem
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import com.bracketmanager.R
import com.bracketmanager.main.MainApp
import com.bracketmanager.models.NameModel
import kotlinx.android.synthetic.main.activity_main.*
import kotlinx.android.synthetic.main.card_name.nameTitle
import org.jetbrains.anko.toast

class NameListActivity : AppCompatActivity(), NameListener {

    var name = NameModel()
    lateinit var app: MainApp

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        var edit = false

        app = application as MainApp

        toolbarAdd.title = "MANAGE"
        setSupportActionBar(toolbarAdd)

        val layoutManager = LinearLayoutManager(this)
        recyclerView.layoutManager = layoutManager
        loadNames()

        btnAdd.setOnClickListener() {
            name.userid = nameTitle.text.toString()

            if (name.userid.isEmpty()) {
                toast("ENTER A DANG NAME, SILLY!")
            }

            else {

                if (edit) {
                    app.names.update(name.copy())

                }

                else {
                    app.names.create(name.copy())

                }

            }

        }

    }

    fun loadNames() {
        showNames(app.names.findAll())
    }

    fun showNames (names: List<NameModel>) {
        recyclerView.adapter = NameAdapter(names, this)
        recyclerView.adapter?.notifyDataSetChanged()
    }

    override fun onCreateOptionsMenu(menu: Menu?): Boolean {
        menuInflater.inflate(R.menu.menu_name, menu)
        return super.onCreateOptionsMenu(menu)
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        when (item?.itemId) {
            R.id.item_cancel -> {
                finish()
            }
        }
        return super.onOptionsItemSelected(item)
    }

    override fun onNameClick(name: NameModel) {
        app.names.delete(name)
        loadNames()
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        loadNames()
        super.onActivityResult(requestCode, resultCode, data)
    }

}